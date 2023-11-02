using Calculator;

while (true)
{
    double[] v = new double[] { 1f, 2f, 3f };
    double[] w = new double[] { 4f, 5f, 6f };

    int selection = Ui.GetMenuSelection();
    Console.WriteLine();
    switch (selection)
    {
        case 1: // CROSS
            v = Ui.RequestVector3("Enter vector v");
            w = Ui.RequestVector3("Enter vector w");
            Console.WriteLine();
            Console.WriteLine("\nANSWER: " + c.AsVector(c.Cross(v, w)));
            break;
        case 2: // DOT
            v = Ui.RequestVector3("Enter vector v");
            w = Ui.RequestVector3("Enter vector w");
            Console.WriteLine();
            Console.WriteLine("\nANSWER: " + c.Dot(v, w));
            break;
        case 3: // MAG
            v = Ui.RequestVector3("Enter vector v");
            Console.WriteLine();
            Console.WriteLine("\nANSWER: " + c.Mag(v));
            break;
        default:
            break;
    }
    Console.WriteLine("\n");
}