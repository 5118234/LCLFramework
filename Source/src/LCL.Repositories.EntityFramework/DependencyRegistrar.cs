using Autofac;
using Autofac.Core;
using LCL;
using LCL.Domain.Repositories;
using LCL.Domain.Services;
using LCL.Infrastructure;
using LCL.Infrastructure.DependencyManagement;
using LCL.LData;
using LCL.Repositories.EntityFramework;
using System.Data.Entity;

namespace LCL.Repositories.EntityFramework
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //data layer
            builder.Register(x => new EfDataProviderManager(x.Resolve<DbSetting>())).As<BaseDataProviderManager>().InstancePerDependency();
            builder.Register(x => x.Resolve<BaseDataProviderManager>().LoadDataProvider()).As<IDataProvider>().InstancePerDependency();
            //������ע��
            builder.RegisterType<EntityFrameworkRepositoryContext>().As<IEntityFrameworkRepositoryContext>().Named("ef", typeof(IEntityFrameworkRepositoryContext)).InstancePerLifetimeScope();
            //�ִ�ģʽע��
            builder.RegisterGeneric(typeof(EntityFrameworkRepository<>)).As(typeof(IRepository<>)).Named("ef", typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EntityFrameworkRepository<,>)).As(typeof(IRepository<,>)).Named("ef", typeof(IRepository<>)).InstancePerLifetimeScope();


            ////DbContextע��
            //builder.Register<IRepositoryContext>(c => new BaseDbContext(dbset.ConnectionString)).Named<IRepositoryContext>(dbset.Name).InstancePerLifetimeScope();
            //builder.Register<BaseDbContext>(c => new BaseDbContext(dbset.ConnectionString)).As(typeof(IRepositoryContext)).InstancePerLifetimeScope();
  

            Logger.LogInfo(Order + " init plugin LCL.Repositories.EntityFramework");
        }

        public int Order
        {
            get { return -1; }
        }
    }
}
