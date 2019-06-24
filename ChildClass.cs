namespace ConsoleApp1
{
    class ChildClass : Parent1, Parent2
    {
        ParentClass1 obj1 = new ParentClass1();
        ParentClass2 obj2 = new ParentClass2();

        public void languages_Level5()
        {
            obj1.languages_Level5();
        }

        public void content()
        {
            obj1.content();
        }

        public void courses_Level5()
        {
            obj2.courses_Level5();

        }
    }
}
