using System.Text;

namespace ConsoleApp1;

public class PoundBox
{
    private int rows;
    private int columns;
    private char[,] frame;

    public PoundBox(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        frame = new char[rows, columns];
    }

    public void initialize()
    {
        //Iterate by Row
        for (int i = 0; i < rows; i++)
        {
            //Iterate by Column
            for (int j = 0; j < columns; j++)
            {
                //Top and Bottom Border
                if (i == 0 || i == rows-1)
                {
                    frame[i, j] = '#';
                }
                //Side Borders
                else if (j == 0 || j == columns-1)
                {
                    frame[i, j] = '#';
                }
                //Diagonals to center
                else if ((i==j || i+j==columns-1) && i<=rows/2)
                {
                    frame[i, j] = '#';
                }
                //Diagonals to bottom
                else if ((i == j-1 || i + j == columns-2) && i>rows/2)
                {
                    frame[i, j] = '#';
                }
                //Filler
                else
                {
                    frame[i, j] = ' ';
                }
            }
        }
    }

    public override String ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sb.Append(frame[i, j]);
            }
            sb.AppendLine();
        }
        
        return sb.ToString();
    }

}