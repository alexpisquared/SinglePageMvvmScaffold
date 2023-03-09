namespace SmrePOC.VM.Helpers;
public static class MvvmInitHelper
{
  public static void InitMVVM(IServiceCollection services)
  {
    _ = services.AddSingleton<MainVM>();

    // _ = services.AddTransient<UserSettings>();
  }
}