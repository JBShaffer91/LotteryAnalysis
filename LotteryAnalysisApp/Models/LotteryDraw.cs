using System;
using System.Collections.Generic;

namespace LotteryAnalysisApp
{
  public class LotteryDraw
  {
    public int Id { get; set; }
    public DateTime DrawDate { get; set; }
    public List<WinningNumber> WinningNumbers { get; set; }

    public LotteryDraw()
    {
        WinningNumbers = new List<WinningNumber>();
    }
  }

  public class WinningNumber
  {
    public int Id { get; set; }
    public int Number { get; set; }
    public int LotteryDrawId { get; set; }
    public LotteryDraw? LotteryDraw { get; set; }
  }
}
