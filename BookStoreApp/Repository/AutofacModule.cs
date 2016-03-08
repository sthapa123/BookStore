using Autofac;
using BookStoreApp.Repository.Implementation;
using BookStoreApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository
{
	public class AutofacModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{

			builder.Register(c => new EfRepository())
				.As<IRepository>()
				.InstancePerLifetimeScope();
		}
	}
}
