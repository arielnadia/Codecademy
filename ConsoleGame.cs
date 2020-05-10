using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string inputKey, out int newX, out int newY)
    {
      newX = 0;
      newY = 0;
      switch (inputKey)
      {
        case "DownArrow":
          newY++;
          break;
        case "UpArrow":
          newY--;
          break;
        case "LeftArrow":
          newX--;
          break;
        case "RightArrow":
          newX++;
          break;
      }
    }
    public new static char UpdateCursor(string inputKey)
    {
      char newIcon = '<';
      switch (inputKey)
      {
        case "DownArrow":
          newIcon = 'v';
          break;
        case "UpArrow":
          newIcon = '^';
          break;
        case "LeftArrow":
          newIcon = '<';
          break;
        case "RightArrow":
          newIcon = '>';
          break;
      }
      return newIcon;
    }
    public new static int KeepInBounds(int coord, int max)
    {
      if (coord >= max)
      {
        coord = (max -1);
        return coord;
      }
      else if (coord < 0)
      {
        coord = 0;
        return coord;
      }
      else
      {
        return coord;
      }
    }
    public new static bool DidScore(int charX, int charY, int fruitX, int fruitY)
    {
      if ((charX == fruitX) && (charY == fruitY))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
