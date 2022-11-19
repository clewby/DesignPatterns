//Behavioral
PaymentClient.Run();

//Creational
FactoryClient client = new FactoryClient(new WindowsGuiFactory());
client.CreateButton().Click();
client = new FactoryClient(new MacGuiFactory());
client.CreateButton().Click();


//Structural
ForecastClient.Run();
