
async Task Main()
{
    await MakeTeaAsync();
}

//static string MakeTea()
//{
//    var water = BoilWater();
//    Console.WriteLine("take the cups out");
//    Console.WriteLine("put tea in cups");
//    var tea = $"pour {water} in cups";
//    Console.WriteLine(tea);
//    return tea;
//}

//static string BoilWater()
//{
//    Console.WriteLine("starts the kettle");
//    Console.WriteLine("waiting for the kettle");
//    Task.Delay(2000).GetAwaiter().GetResult();
//    Console.WriteLine("kettle finished boiling");
//    return "water";
//}

static async Task<string> MakeTeaAsync()
{
    var boilingWater = BoilWaterAsync();

    Console.WriteLine("take the cups out - 3");

    Console.WriteLine("put tea in cups - 4");

    var water = await boilingWater;

    var tea = $"pour {water} in cups - 6";

    Console.WriteLine(tea);

    return tea;
}

static async Task<string> BoilWaterAsync()
{
    Console.WriteLine("starts the kettle - 1");

    Console.WriteLine("waiting for the kettle - 2");

    await Task.Delay(300);

    Console.WriteLine("kettle finished boiling - 5");

    return "water";
}

await Main();
