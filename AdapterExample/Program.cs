ICharger charger = new UsbChargerAdapter(new OldCharger());
charger.ChargeUsbDevice();

interface ICharger
{
    void ChargeUsbDevice();
}

sealed class OldCharger
{
    public void ChargeWithRoundPlug() => Console.WriteLine("Carregando com plugue redondo.");
}

sealed class UsbChargerAdapter : ICharger
{
    private readonly OldCharger oldCharger;

    public UsbChargerAdapter(OldCharger oldCharger) => this.oldCharger = oldCharger;

    public void ChargeUsbDevice()
    {
        Console.WriteLine("Adaptando USB para plugue redondo...");
        oldCharger.ChargeWithRoundPlug();
    }
}
