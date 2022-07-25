namespace Ocean.Interface
{
    public interface IView
    {
        void InputRowsAndColumn(Ocean ocean); // done

        public void InputValues(Ocean ocean); // done

        void InputIterations(Ocean ocean); // done

        void PrintIterations(Ocean ocean); // done

        public void PrintException(string message); // done

        void Print(Ocean ocean);             // done

        public void DisplayBorder(Ocean ocean); // done

        public void DisplayCells(Ocean ocean); // done

    }
}
