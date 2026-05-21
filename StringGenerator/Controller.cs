namespace StringGenerator
{
    public class Controller
    {
        private Model model = new Model();
        private View view = new View();

        public void Run(string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out int seed))
            {
                view.ShowError();
                return;
            }

            string result = model.Generate(seed);
            view.ShowResult(result);
        }
    }
}