namespace task
{
    class Pupil
    {
        public virtual void Study()
        { }

        public virtual void Read()
        { }

        public virtual void Write()
        { }

        public virtual void Relax()
        { }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil: Study-exceletn");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil: Read-exceletn");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil: Write-exceletn");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil: Relax-exceletn");
        }

    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil: Study-Good");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil: Read-Good");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil: Write-Good");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil: Relax-Good");
        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil: Study-Bad");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil: Read-Bad");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil: Write-Bad");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil: Relax-Bad");
        }

    }
}