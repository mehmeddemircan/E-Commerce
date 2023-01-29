


using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using E_Commerce1.Business.Abstract;
using E_Commerce1.Business.Concrete;
using E_Commerce1.Core.Utilities.Interceptors;
using E_Commerce1.DataAccess.Abstract;
using E_Commerce1.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();


            builder.RegisterType<SubCategoryManager>().As<ISubCategoryService>();
            builder.RegisterType<SubCategoryRepository>().As<ISubCategoryRepository>();


            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<BrandRepository>().As<IBrandRepository>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            builder.RegisterType<ImageManager>().As<IImageService>();
            builder.RegisterType<ImageRepository>().As<IImageRepository>();

            builder.RegisterType<SizeManager>().As<ISizeService>();
            builder.RegisterType<SizeRepository>().As<ISizeRepository>();

            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<ColorRepository>().As<IColorRepository>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
