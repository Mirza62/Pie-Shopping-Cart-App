using Autofac;
using BethanysPie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPie.RepositoryRegistrationModule
{
    public class RegistrationModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder);

            builder.RegisterType<PieRepository>().As<IPieRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>().InstancePerLifetimeScope();

          //builder.RegisterType<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
        }
    }
}
