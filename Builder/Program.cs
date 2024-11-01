using Builder;

IDeveloper androidDeveloper = new AndroidDeveloper();
Director director = new Director(androidDeveloper);
Phone samsung = director.MountFullPhone();
Console.WriteLine(samsung.AboutPhone());

IDeveloper iPhoneDeveloper = new IPhoneDeveloper();
director = new Director(iPhoneDeveloper);
Phone iphone = director.MountOnlyPhone();
Console.WriteLine(iphone.AboutPhone());