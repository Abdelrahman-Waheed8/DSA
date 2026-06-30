public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] box = new HashSet<char>[9];

        for(int i = 0; i <9 ; i++)
        {
            columns[i] = new HashSet<char>();
            rows[i] = new HashSet<char>();
            box[i] = new HashSet<char>();
        }

        for(int i = 0; i < 9 ; i++)
        {
            for(int j = 0; j <9 ; j++)
            {
                char current = board[i][j];
                int boxSize = (i/3) * 3 + (j/3);

                if(current == '.') continue;

                if(rows[i].Contains(current) || 
                   columns[j].Contains(current) || 
                   box[boxSize].Contains(current))            
                {
                    return false;
                }

                rows[i].Add(current);
                columns[j].Add(current);
                box[boxSize].Add(current);
            }
        }
        return true;
    }
}
