using Bunit;
using Proyecto.UI.Interfaces;
using Proyecto.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using System;
using Proyecto.UI.Components;
using Moq;
using Proyecto.UI.Pages;
using System.Collections.Generic;

namespace Proyecto.Test
{
    public class Tests
    {
        [Fact]
        public void LoginTest()
        {
            using var ctx = new TestContext();

            ctx.Services.AddHttpClient<IProductService, ProductService>(client => { client.BaseAddress = new Uri("http://localhost:47786"); });

            var component = ctx.RenderComponent<Products>();

            //var image = component.Find("img");
        }
    }
}
