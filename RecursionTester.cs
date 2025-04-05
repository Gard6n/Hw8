namespace prove_08;

public static class RecursionTester {
    /// <summary>
    /// Entry point for the Prove 8 tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        Console.WriteLine(SumSquaresRecursive(10)); // 385
        Console.WriteLine(SumSquaresRecursive(100)); // 338350

        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        PermutationsChoose("ABCD", 3);
        // Expected Result (order may be different):
        // ABC
        // ABD
        // ACB
        // ACD
        // ADB
        // ADC
        // BAC
        // BAD
        // BCA
        // BCD
        // BDA
        // BDC
        // CAB
        // CAD
        // CBA
        // CBD
        // CDA
        // CDB
        // DAB
        // DAC
        // DBA
        // DBC
        // DCA
        // DCB

        Console.WriteLine("---------");
        PermutationsChoose("ABCD", 2);
        // Expected Result (order may be different):
        // AB
        // AC
        // AD
        // BA
        // BC
        // BD
        // CA
        // CB
        // CD
        // DA
        // DB
        // DC

        Console.WriteLine("---------");
        PermutationsChoose("ABCD", 1);
        // Expected Result (order may be different):
        // A
        // B
        // C
        // D

        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
        Console.WriteLine(CountWaysToClimb(5)); // 13
        Console.WriteLine(CountWaysToClimb(20)); // 121415
        // Uncomment out the test below after implementing memoization.  It won't work without it.
        // TODO Problem 3
        // Console.WriteLine(CountWaysToClimb(100));  // 180396380815100901214157639

        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
        WildcardBinary("110*0*");
        // 110000
        // 110001
        // 110100
        // 110101
        WildcardBinary("***");
        // 000   
        // 001   
        // 010
        // 011
        // 100
        // 101
        // 110
        // 111

        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
        Maze smallMaze = new Maze(3, 3, new[] { 1, 1, 1, 1, 0, 1, 1, 1, 2 });
        SolveMaze(smallMaze);
        // Two Solutions (order in each solution should match):
        // <List>{(0, 0), (0, 1), (0, 2), (1, 2), (2, 2)}
        // <List>{(0, 0), (1, 0), (2, 0), (2, 1), (2, 2)}

        Maze bigMaze = new Maze(20, 20,
            new[] {
                1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1,
                1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1,
                0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0,
                0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1,
                1, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1,
                0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1,
                0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1,
                1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1,
                0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1,
                0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,
                0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1,
                0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1,
                1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0,
                0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0,
                0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1,
                0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0,
                0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0,
                1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 2
            });
        SolveMaze(bigMaze);
        // One Solution (order should match):
        // <List>{(0, 0), (0, 1), (0, 2), (0, 3), (1, 3), (2, 3), (3, 3), (3, 4), (3, 5),
        // (3, 6), (2, 6), (1, 6), (1, 7), (1, 8), (1, 9), (1, 10), (2, 10), (3, 10),
        // (4, 10), (5, 10), (5, 9), (5, 8), (5, 7), (5, 6), (5, 5), (5, 4), (5, 3),
        // (5, 2), (5, 1), (5, 0), (6, 0), (7, 0), (8, 0), (9, 0), (10, 0), (10, 1),
        // (10, 2), (10, 3), (10, 4), (10, 5), (10, 6), (9, 6), (8, 6), (8, 7), (8, 8),
        // (7, 8), (7, 9), (7, 10), (7, 11), (7, 12), (7, 13), (6, 13), (5, 13), (5, 14), 
        // (5, 15), (5, 16), (5, 17), (5, 18), (5, 19), (6, 19), (7, 19), (8, 19), (9, 19),
        // (10, 19), (11, 19), (12, 19), (12, 18), (12, 17), (12, 16), (12, 15), (12, 14),
        // (12, 13), (12, 12), (12, 11), (12, 10), (12, 9), (13, 9), (14, 9), (15, 9),
        // (15, 8), (15, 7), (15, 6), (15, 5), (14, 5), (13, 5), (12, 5), (12, 4), (12, 3),
        // (12, 2), (12, 1), (13, 1), (14, 1), (15, 1), (16, 1), (17, 1), (17, 2), (17, 3),
        // (17, 4), (17, 5), (18, 5), (19, 5), (19, 6), (19, 7), (19, 8), (19, 9), (19, 10),
        // (19, 11), (19, 12), (18, 12), (17, 12), (16, 12), (16, 13), (16, 14), (16, 15), 
        // (17, 15), (18, 15), (18, 16), (18, 17), (18, 18), (18, 19), (19, 19)}
    }

 
 public static int SumSquaresRecursive(int n) {
    // Base case: if n is less than or equal to 0, return 0
    if (n <= 0) {
        return 0;
    }
    
    // Recursive case: sum of squares from 1 to n is
    // n² + sum of squares from 1 to (n-1)
    return (n * n) + SumSquaresRecursive(n - 1);
}

    public static void PermutationsChoose(string letters, int size, string word = "") {
    // Base case: if we've built a word of the desired size, print it
    if (word.Length == size) {
        Console.WriteLine(word);
        return;
    }
    
    // Try adding each available letter to our current word
    for (int i = 0; i < letters.Length; i++) {
        char current = letters[i];
        
        // Remove the current letter from available letters
        string remaining = letters.Remove(i, 1);
        
        // Recursively build permutations with the current letter added
        PermutationsChoose(remaining, size, word + current);
    }
}

    /// <summary>
    /// #############
    /// # Problem 3 #
    /// #############
    /// Imagine that there was a staircase with 's' stairs.  
    /// We want to count how many ways there are to climb 
    /// the stairs.  If the person could only climb one 
    /// stair at a time, then the total would be just one.  
    /// However, if the person could choose to climb either 
    /// one, two, or three stairs at a time (in any order), 
    /// then the total possibilities become much more 
    /// complicated.  If there were just three stairs,
    /// the possible ways to climb would be four as follows:
    ///
    ///     1 step, 1 step, 1 step
    ///     1 step, 2 step
    ///     2 step, 1 step
    ///     3 step
    ///
    /// With just one step to go, the ways to get
    /// to the top of 's' stairs is to either:
    ///
    /// - take a single step from the second to last step, 
    /// - take a double step from the third to last step, 
    /// - take a triple step from the fourth to last step
    ///
    /// We don't need to think about scenarios like taking two 
    /// single steps from the third to last step because this
    /// is already part of the first scenario (taking a single
    /// step from the second to last step).
    ///
    /// These final leaps give us a sum:
    ///
    /// CountWaysToClimb(s) = CountWaysToClimb(s-1) + 
    ///                       CountWaysToClimb(s-2) +
    ///                       CountWaysToClimb(s-3)
    ///
    /// To run this function for larger values of 's', you will need
    /// to update this function to use memoization.  The parameter
    /// 'remember' has already been added as an input parameter to 
    /// the function for you to complete this task.
    ///
    /// The last test case is commented out because it will not work
    /// until the memoization is implemented.
    /// </summary>
    public static decimal CountWaysToClimb(int s, Dictionary<int, decimal>? remember = null) {
    // Initialize the memoization dictionary if it's null
    if (remember == null)
        remember = new Dictionary<int, decimal>();
    
    // Check if we've already calculated this value
    if (remember.ContainsKey(s))
        return remember[s];
    
    // Base Cases
    if (s == 0)
        return 0;
    if (s == 1)
        return 1;
    if (s == 2)
        return 2;
    if (s == 3)
        return 4;

    // Solve using recursion with memoization
    decimal ways = CountWaysToClimb(s - 1, remember) + 
                   CountWaysToClimb(s - 2, remember) + 
                   CountWaysToClimb(s - 3, remember);
    
    // Store the result in our memoization dictionary
    remember[s] = ways;
    
    return ways;
}

    public static void WildcardBinary(string pattern) {
    // Find the first wildcard in the pattern
    int wildcardIndex = pattern.IndexOf('*');
    
    // Base case: No wildcards found, this is a complete binary string
    if (wildcardIndex == -1) {
        Console.WriteLine(pattern);
        return;
    }
    
    // Create two new patterns by replacing the first wildcard with 0 and 1
    string pattern0 = pattern.Substring(0, wildcardIndex) + "0" + pattern.Substring(wildcardIndex + 1);
    string pattern1 = pattern.Substring(0, wildcardIndex) + "1" + pattern.Substring(wildcardIndex + 1);
    
    // Recursively process both new patterns
    WildcardBinary(pattern0);
    WildcardBinary(pattern1);
}
 
    public static void SolveMaze(Maze maze, int x = 0, int y = 0, List<ValueTuple<int, int>>? currPath = null) {
    // If this is the first time running the function, then we need
    // to initialize the currPath list.
    if (currPath == null)
        currPath = new List<ValueTuple<int, int>>();
    
    // Add the current position to the path
    currPath.Add((x, y));
    
    // Check if we've reached the end of the maze
    if (maze.IsEnd(x, y)) {
        Console.WriteLine(currPath.AsString());
        
        // Remove the current position from the path before returning
        // so it doesn't affect other recursive calls
        currPath.RemoveAt(currPath.Count - 1);
        return;
    }
    
    // Try moving in all four directions: right, down, left, up
    int[] dx = { 1, 0, -1, 0 };
    int[] dy = { 0, 1, 0, -1 };
    
    for (int i = 0; i < 4; i++) {
        int newX = x + dx[i];
        int newY = y + dy[i];
        
        // Check if the move is valid
        if (maze.IsValidMove(currPath, newX, newY)) {
            // Recursively explore this path
            SolveMaze(maze, newX, newY, currPath);
        }
    }
    
    // Remove the current position from the path before backtracking
    currPath.RemoveAt(currPath.Count - 1);
}
}