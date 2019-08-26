using System;

namespace Domain
{
    public class Value
    {
        //entity framework is convention based. if prop called Id, then it will become primary key
        //because its an int, then it will config db to use auto-generated number
        //this style of DB creation is called code-first
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


