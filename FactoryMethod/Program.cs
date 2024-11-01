using FactoryMethod;

IWorkShop creator = new CarWorkShop();
IProduction car = creator.Create();
creator = new TruckWorkShop();
IProduction truck = creator.Create();
car.Release();
truck.Release();

Developer dev = new PanelDeveloper("Рекун Кирпич продакшн");
House housePanel = dev.Create();
dev=new WoodDeveloper("Рepe деревяшка строй");
House housePepe = dev.Create();


