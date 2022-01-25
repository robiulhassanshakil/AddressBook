using AddressBookAPI.Models;
using Autofac;

namespace AddressBookAPI
{
    public class AddressBookAPIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContactListModel>().AsSelf();
            builder.RegisterType<CreateCourseModel>().AsSelf();

            base.Load(builder);
        }
    }
}
