using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EFCache
{
  public static  class EFStaticServiceProvider
    {

        /// <summary>
        /// A lazy loaded thread-safe singleton App ServiceProvider.
        /// It's required for static `Cacheable()` methods.
        /// </summary>
       
            private static readonly Lazy<IServiceProvider> _serviceProviderBuilder =
                new Lazy<IServiceProvider>(getServiceProvider, LazyThreadSafetyMode.ExecutionAndPublication);

            /// <summary>
            /// Defines a mechanism for retrieving a service object.
            /// </summary>
            public static IServiceProvider Instance { get; } = _serviceProviderBuilder.Value;

            private static IServiceProvider getServiceProvider()
            {
                var serviceProvider = EFServiceCollectionExtensions.ServiceCollection?.BuildServiceProvider();
                return serviceProvider ?? throw new InvalidOperationException("Please add `AddEFSecondLevelCache()` method to your `IServiceCollection`.");
            }
        }
    
}
