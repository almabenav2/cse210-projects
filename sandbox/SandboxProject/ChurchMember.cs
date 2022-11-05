using System;
using System.Collections.Generic;

namespace SandboxProject
{
    public class ChurchMember : Person 
    {
        private string _calling = "";


        public ChurchMember() : base()
        {

        }
        public ChurchMember(string firstName, string lastName, string calling) : base(firstName, lastName, calling)
        {
            _calling = calling;
        }

        public string GetCalling()
        {
            return _calling;
        }

        public void SetCalling(string calling)
        {
            _calling = calling;
        }

        public string GetFullInfo()
        {
            return $"{_firstName }{_lastName} calling: {_calling}";

        }
    }











}