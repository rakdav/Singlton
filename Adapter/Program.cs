using Adapter;

double kg = 210;
double lb = 210;
//IScales rScales = new RussianScales(kg);
//IScales bScales = new AdapterBritishScales(new BritishScales(lb));
//Console.WriteLine(rScales.GetWeight());
//Console.WriteLine(bScales.GetWeight());
IScales bScales = new BritishScales(lb);
IScales rScales = new AdapterRussianScales(new RussianScales(kg));
Console.WriteLine(rScales.GetWeight());
Console.WriteLine(bScales.GetWeight());