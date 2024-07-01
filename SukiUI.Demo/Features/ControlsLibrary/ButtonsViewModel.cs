using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Material.Icons;
using System.Threading.Tasks;

namespace SukiUI.Demo.Features.ControlsLibrary;

public partial class ButtonsViewModel() : DemoPageBase("Buttons", MaterialIconKind.CursorDefaultClick)
{
    [ObservableProperty] private bool _isBusy;
    [ObservableProperty] private bool _isEnabled = true;

    [RelayCommand]
    private Task ButtonClicked()
    {
        if (IsBusy)
            return Task.CompletedTask;

        return Task.Run(async () =>
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        });
    }
}