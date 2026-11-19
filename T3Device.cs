using System;

namespace OOP_HT4;


class Device
{
    private string _model;

    protected string Model
    {
        get { return _model; }
    }

    public Device(string model)
    {
        _model = model;
    }

    public void ShowModel()
    {
        Console.WriteLine(_model);
    }
}

class Phone : Device
{
    public Phone(string model) : base(model)
    {
    }

    public void ShowPhoneModel()
    {
        Console.WriteLine(Model);   
    }

    
}
