// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using SpeedyAir.DataSource;
using SpeedyAir.DataSource.Interface;
using SpeedyAir.Output;
using SpeedyAir.Output.Interface;
using SpeedyAir.Services;
using SpeedyAir.Services.Interface;

// Setup DI container
var serviceProvider = new ServiceCollection()
    .AddScoped<IOutputFactory, OutputFactory>()
    .AddScoped<IDataSource, DataSource>()
    .AddScoped<IDictionaryDataSource, DictionaryDataSource>()
    .AddScoped<ITransactionDataSource, TransactionDataSource>()
    .AddScoped<ISchedulesService, SchedulesService>()
    .AddScoped<IFlightOrderService, FlightOrderService>()
    .BuildServiceProvider();


var scheduleService = serviceProvider.GetService<ISchedulesService>();
var flightOrderService = serviceProvider.GetService<IFlightOrderService>();
var outputFactory = serviceProvider.GetService<IOutputFactory>();

outputFactory.CreateOutput(OutputType.Console).OutputSchedule(scheduleService.GetSchedules());
outputFactory.CreateOutput(OutputType.Console).OutputFlightOrders(flightOrderService.BatchOrders());


