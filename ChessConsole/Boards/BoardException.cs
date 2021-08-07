using System;

namespace Boards
{
    class BoardException:Exception
    {
        //recieve the message and repass to the C# Exception class
        public BoardException(string message): base(message)
        {
        }
    }
}
