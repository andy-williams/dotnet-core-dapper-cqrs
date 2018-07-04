using CQRS.Dapper.Domain.Commands;
using CQRS.Dapper.Domain.Common;
using CQRS.Dapper.Domain.Queries;
using CQRS.Dapper.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Dapper
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IDbConnectionFactory>(x => new MysqlDbConnectionFactory("Server=cqrsdapper.database;uid=library_admin;pwd=password;database=library"));
            services.AddCommandHandler<AddBookHandler, AddBook>();
            services.AddCommandHandler<DeleteBookHandler, DeleteBook>();

            services.AddScoped<ICommandHandler<DeleteBook>, DeleteBookHandler>();
            services.AddScoped<ICommandsProcessor, CommandsProcessor>();

            services.AddScoped<IQueriesProcessor, QueriesProcessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
