using System.Collections.Generic; 

namespace  learerBoard.Models 
{
    public class learerBoard 
    {
        public float lowTime { get; set; }

        public string playerName {get; set; }

        public List<Session> Sessions {get; set;}
    }
}