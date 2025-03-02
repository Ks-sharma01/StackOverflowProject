using System.Web.Http;
using Unity;
using Unity.WebApi;
using Unity.Mvc5;
using System.Web.Mvc;
using StackOverflowProject.ServiceLayer;

namespace StackOverflowProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IQuestionService, QuestionService>();
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}