using Microsoft.EntityFrameworkCore;
using ZaminTemplate.Infra.Data.Sql.Commands.Common;
using ZaminTemplate.Infra.Data.Sql.Queries.Common;
using Zamin.EndPoints.Web;
using Zamin.EndPoints.Web.StartupExtentions;
using Zamin.Utilities.Configurations;

var builder = new ZaminProgram().Main(args, "appsettings.json", "appsettings.zamin.json", "appsettings.serilog.json");

//Configuration
ConfigurationManager Configuration = builder.Configuration;
builder.Services.AddZaminApiServices(Configuration);
builder.Services.AddDbContext<ZaminTemplateCommandDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("ZaminTemplateCommand_ConnectionString")));
builder.Services.AddDbContext<ZaminTemplateQueryDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("ZaminTemplateQuery_ConnectionString")));

//Middlewares
var app = builder.Build();
var zaminOptions = app.Services.GetService<ZaminConfigurationOptions>();

app.UseZaminApiConfigure(zaminOptions, app.Environment);

app.Run();