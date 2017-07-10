using Autofac;
using LCL;
using LCL.Domain.Repositories;
using LCL.Domain.Services;
using LCL.Infrastructure;
using LCL.Infrastructure.DependencyManagement;
using LCL.LData;

namespace LCL.Repositories.MongoDB
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //������ע��
            builder.RegisterType<MongoDBRepositoryContext>().As<IMongoDBRepositoryContext>().Named("mongodb", typeof(IMongoDBRepositoryContext)).InstancePerLifetimeScope();
            //�ִ�ģʽע��
            builder.RegisterGeneric(typeof(MongoDBRepository<>)).As(typeof(IRepository<>)).Named("mongodb", typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(MongoDBRepository<,>)).As(typeof(IRepository<,>)).Named("mongodb", typeof(IRepository<,>)).InstancePerLifetimeScope();

            Logger.LogInfo(Order + " init plugin LCL.Repositories.MongoDB");
        }

        public int Order
        {
            get { return -2; }
        }
    }
}
