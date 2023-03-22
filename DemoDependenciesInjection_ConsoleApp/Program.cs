using Autofac;

var builder = new ContainerBuilder();

builder.Register(c => Guid.NewGuid()).As<Guid>().InstancePerDependency();
builder.RegisterType<PeopleGen>().AsSelf().SingleInstance();

IContainer container = builder.Build();

PeopleGen gen = container.Resolve<PeopleGen>();

Console.WriteLine(gen.CreatePerson().Id);
Console.WriteLine(gen.CreatePerson().Id);
Console.WriteLine(gen.CreatePerson().Id);
Console.WriteLine(container.Resolve<PeopleGen>().CreatePerson().Id);
