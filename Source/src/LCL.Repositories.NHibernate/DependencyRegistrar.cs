using Autofac;
using LCL;
using LCL.Domain.Repositories;
using LCL.Domain.Services;
using LCL.Infrastructure;
using LCL.Infrastructure.DependencyManagement;
using LCL.LData;

namespace LCL.Repositories.NHibernate
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //������ע��
            builder.RegisterType<NHibernateContext>().As<INHibernateContext>().Named("NHibernate", typeof(INHibernateContext)).InstancePerLifetimeScope();
            //�ִ�ģʽע��
            builder.RegisterGeneric(typeof(NHibernateRepository<>)).As(typeof(IRepository<>)).Named("NHibernate", typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(NHibernateRepository<,>)).As(typeof(IRepository<,>)).Named("NHibernate", typeof(IRepository<,>)).InstancePerLifetimeScope();

            Logger.LogInfo(Order + " init plugin LCL.Repositories.NHibernate");
        }

        public int Order
        {
            get { return -2; }
        }
    }
}
