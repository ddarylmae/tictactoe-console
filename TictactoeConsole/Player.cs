namespace TicTacToeConsole
{
    public class Player
    {
        public bool ValidateCoordinates(string playerInput)
        {
            var coordinates = playerInput.Split(',');
            
            if (playerInput.Equals("q") || coordinates.Length == 2 && 
                int.TryParse(coordinates[0], out var row) &&
                int.TryParse(coordinates[1], out var column) && 
                row > 0 && row < 4 && 
                column > 0 && column < 4)
            {
                return true;
            }
            
            return false;
        }
    }
}