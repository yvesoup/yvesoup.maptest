using yvesoup;

namespace yvesoup.maptest;

public class Mod : IMod {
    public Config Config;

    public Mod(IModInterface modInterface) {
        this.Config = modInterface.ReadConfig<Config>();
        modInterface.Logger.Information("Hello, world!");
    }

    public void Dispose() {
        // Cleanup anything you do here
    }
}
