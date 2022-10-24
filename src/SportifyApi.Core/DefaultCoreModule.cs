using Autofac;
using SportifyApi.Core.Interfaces;
using SportifyApi.Core.Services;

namespace SportifyApi.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
