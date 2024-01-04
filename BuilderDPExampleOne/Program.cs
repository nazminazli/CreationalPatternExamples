new Computer.Builder().AddCPU("Intel-I9 Thunder").AddRAM("32 GB").Build().ToString();
new Computer.Builder().AddRAM("16 GB").AddHardDisk("Samsung SSD 512 GB").Build().ToString();

public class Computer
{
    private readonly string _cpu;
    private readonly string _ram;
    private readonly string _hardDisk;
    public Computer(string cpu, string ram, string hardDisk)
    {
        _cpu = cpu;
        _ram = ram;
        _hardDisk = hardDisk;
    }

    public class Builder
    {
        private string? _cpu;
        private string? _ram;
        private string? _hardDisk;

        public Builder AddCPU(string cpu)
        {
            _cpu = cpu;
            return this;
        }

        public Builder AddRAM(string ram)
        {
            _ram = ram;
            return this;
        }

        public Builder AddHardDisk(string hardDisk)
        {
            _hardDisk = hardDisk;
            return this;
        }

        public Computer Build()
        {
            return new Computer(_cpu, _ram, _hardDisk);
        }
    }

    public override string ToString()
    {
        Console.WriteLine($"Cpu: {_cpu} - Ram: {_ram} - Hard Drive: {_hardDisk}");
        return base.ToString();
    }
}

