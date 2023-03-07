
// https://www.youtube.com/watch?v=il9gl8MH17s&ab_channel=RawCoding
// https://www.youtube.com/watch?v=3GhKdDCvtKE&ab_channel=RawCoding

async Task Main()
{
    await MakeTeaAsync();
}

await Main();

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


