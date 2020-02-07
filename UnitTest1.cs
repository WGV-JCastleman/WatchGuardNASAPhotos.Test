using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Xunit;
using WatchGuardNASAPhotos.Services;
using WatchGuardNASAPhotos.Models;

namespace WatchGuardNASAPhotos.Test
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetPhotos()
        {
            var services = new ServiceCollection();
            services.UseServices();
            var serviceProvider = services.BuildServiceProvider();

            var service = serviceProvider.GetRequiredService<IPhotoService>();

            var tasks = await service.GetPhotos();

            Assert.NotEmpty(tasks);
        }
    }
}
