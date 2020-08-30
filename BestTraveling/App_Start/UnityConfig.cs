using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using bt_Services;
using bt_Services.IServices;
using bt_Services.Services;
using BT.AdminService.IServices;
using BT.AdminService.Services;

namespace BestTraveling
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICollegeService, CollegeService>();
            container.RegisterType<ICountryService, CountryService>();
            container.RegisterType<ICountryService, CountryService>();
            container.RegisterType<IStateService, StateService>();
            container.RegisterType<IRoleService,RoleService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}