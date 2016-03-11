using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace StickyNotes {
	public class Data {
		private static ISessionFactory _sessionFactory;

		private static ISessionFactory SessionFactory {
			get {
				if( _sessionFactory == null ) {
					var configuration = new Configuration();
					configuration.Configure();
					configuration.AddAssembly( Assembly.GetCallingAssembly() );
					_sessionFactory = configuration.BuildSessionFactory();
				}
				return _sessionFactory;
			}
		}

		public static ISession OpenSession() {
			return SessionFactory.OpenSession();
		}
	}
}
