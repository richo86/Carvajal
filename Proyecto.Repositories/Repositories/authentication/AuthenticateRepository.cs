using Dapper;
using Proyecto.Models;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Proyecto.Repositories.Repositories.authentication
{
    public class AuthenticateRepository : IAuthenticateRepository
    {
        private SqlConnectionConf _connectionString;

        public AuthenticateRepository(SqlConnectionConf connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<Users> GetUser(int id)
        {
            var database = dbConnection();

            var query = @"SELECT *
                        FROM users
                        WHERE id = @Id";

            return await database.QueryFirstOrDefaultAsync<Users>(query, new { Id = id});
        }

        public async Task<bool> RegisterUser(Users user)
        {
            var database = dbConnection();

            var query = @"INSERT INTO users (name, email, password, role, registerDate, passwordExpiration, signInRetries, lockout, isLoggedIn)
                        VALUES (@name, @email, @password, @role, @registerDate, @passwordExpiration, @signInRetries, @lockout, @isLoggedIn)";

            int result = await database.ExecuteAsync(query, new { user.name, user.email, user.password, user.role, user.registerDate, user.passwordExpiration, signInRetries = 0, lockout = false, isLoggedIn = true });

            return result > 0;
        }

        public async Task<Users> SignIn(string email, string password)
        {
            Users emptyUser = new Users();

            var database = dbConnection();

            var query = @"SELECT *
                        FROM users
                        WHERE email = @Email";

            try
            {
                var user = await database.QueryFirstOrDefaultAsync<Users>(query, new { Email = email });

                if(user != null)
                {
                    if (user.password == password && user.passwordExpiration > DateTime.Now && (user.lockoutTime < DateTime.Now || user.lockoutTime == null))
                    {
                        user.isLoggedIn = "true";
                        user.signInRetries = 0;
                    }
                    else
                    {
                        user.signInRetries = user.signInRetries + 1;
                        user.isLoggedIn = "false";
                        if (user.signInRetries > 3)
                        {
                            user.lockout = "true";
                            user.lockoutTime = DateTime.Now.AddHours(4);
                        }
                    }

                    var updateQuery = @"UPDATE users
                        SET isLoggedIn = @IsLoggedIn, signInRetries = @SignInRetries, lockout = @Lockout, lockoutTime = @LockoutTime
                        WHERE email = @Email";

                    await database.ExecuteAsync(updateQuery, new { IsLoggedIn = user.isLoggedIn, SignInRetries = user.signInRetries, Lockout = user.lockout, LockoutTime = user.lockoutTime, Email = email });

                    return user;
                }
                else
                {
                    return emptyUser;
                }

                
            }
            catch(Exception)
            {
                return emptyUser;
            }            
        }

        public async Task<bool> SignOut(int id)
        {
            var user = await GetUser(id);

            user.isLoggedIn = "false";

            var database = dbConnection();
            
            var updateQuery = @"UPDATE users
                        SET isLoggedIn = @IsLoggedIn
                        WHERE id = @Id";

            var result = await database.ExecuteAsync(updateQuery, new { IsLoggedIn = user.isLoggedIn, Id = id });

            return result > 0;
        }
    }
}
