using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public int width = 16;
    public int height = 16;
    public int mineCount = 32;

    private Board board;
    private Cell [,] state;
    private bool gameOver;
    public GameObject textWin;
    public GameObject textLose;
    public GameObject textInstruct;

    private void OnValidate(){
        mineCount= Mathf.Clamp(mineCount, 0, width*height);
    }
    private void Awake()
    {
        board=GetComponentInChildren<Board>();
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        textWin.SetActive(false);
        textLose.SetActive(false);
        textInstruct.SetActive(false);
        state= new Cell[width, height];
        gameOver=false;
        GenerateCells();
        GenerateMines();
        GenerateNumbers();

        Camera.main.transform.position = new Vector3(width/2f, height/2f, -10f);
        board.Draw(state);
    }

    private void GenerateCells()
    {
        for (int x=0; x<width; x++)
        {
            for(int y=0; y<height; y++)
            {
                Cell cell = new Cell();
                cell.position= new Vector3Int(x,y,0);
                cell.type = Cell.Type.Empty;
                state[x,y]=cell;
            }
        }
    }
    private void GenerateMines()
    {
        for (int i=0; i < mineCount; i++)
        {
            int x = Random.Range(0, width);
            int y = Random.Range(0, height);

            while(state[x,y].type== Cell.Type.Mine)
            {
                x++;

                if (x>=width)
                {
                    x = 0;
                    y++;

                    if (y>=height)
                    {
                        y=0;
                    }
                }
            }
            
            state[x,y].type = Cell.Type.Mine;
            
            // state[x,y].revealed = true;
            //test code ^
        }
    }

    private void GenerateNumbers()
    {
        for (int x=0; x<width; x++)
        {
            for(int y=0; y<height; y++)
            {
                if (state[x,y].type!=Cell.Type.Mine){
                    
                    int mineTouch=0;
                    
                    //top left
                    if (x!=0 && y!=(height-1) && state[x-1,y+1].type==Cell.Type.Mine){
                        mineTouch++;
                    }
                    //top middle
                    if (y!=(height-1) && state[x,y+1].type==Cell.Type.Mine){
                        mineTouch++;
                    }
                    //top right
                    if (x!=(width-1) && y!=(height-1) && state[x+1,y+1].type==Cell.Type.Mine){
                        mineTouch++;
                    }
                    //middle left
                    if ( x!=0 && state[x-1,y].type==Cell.Type.Mine){
                        mineTouch++;
                    }
                    //middle right
                    if (x!=(width-1) && state[x+1,y].type==Cell.Type.Mine){
                        mineTouch++;
                    }
                    //bottom left
                    if (x!=0 && y!=0 && state[x-1,y-1].type==Cell.Type.Mine){
                        mineTouch++;
                    }
                    if (y!=0 && state[x,y-1].type==Cell.Type.Mine){
                        mineTouch++;
                    }
                    if (x!=(width-1) && y!=0 && state[x+1,y-1].type==Cell.Type.Mine){
                        mineTouch++;
                    }

                    if (mineTouch>0){
                        state[x,y].type=Cell.Type.Number;
                        state[x,y].number=mineTouch;
                        //testcode
                        // state[x,y].revealed=true;
                    }
                }  
                
            }
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            NewGame();
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadSceneAsync("Title");
        }

        else if (gameOver==false){
            //1 is right click on mouse/touchpad
            if (Input.GetMouseButtonDown(1)){
                Flag();
                
            }
            //0 is left click on mouse/touchpad
            if (Input.GetMouseButtonDown(0)){
                Reveal();
                Win();
                
            }
        
        }
    }

    private void Reveal()
    {
        Vector3 worldPosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int cellPosition = board.tilemap.WorldToCell(worldPosition);
        Cell cell= GetCell(cellPosition.x, cellPosition.y);

        if (cell.type ==Cell.Type.Invalid || cell.revealed || cell.flagged){
            return;        
        }

        if(cell.type == Cell.Type.Empty){
            cell.revealed=true;
            Flood(cellPosition.x,cellPosition.y);
        } else if(cell.type == Cell.Type.Number){
            cell.revealed=true;
        } else{
            cell.exploded=true;
            cell.revealed=true;
            Explode(cell);
        }
        state[cellPosition.x, cellPosition.y]=cell;
        board.Draw(state);
        
    }
    
    private void Explode(Cell cell)
    {
        Debug.Log("Game Over!");
        gameOver=true;
        textLose.SetActive(true);
        textInstruct.SetActive(true);

        for(int x=0;x<width; x++)
        {
            for (int y=0; y<height; y++)
            {
                cell=state[x,y];

                if (cell.type==Cell.Type.Mine)
                {
                    cell.revealed=true;
                    state[x,y]=cell;
                }
            }
        }
    }

    private void Flood(int x, int y){
        //reveal all empty cells touching revealed cells, until you hit number and reveal that.
        if (state[x,y].type==Cell.Type.Empty){
                    
                    //top left
                    if (x!=0 && y!=(height-1) && state[x-1,y+1].type!=Cell.Type.Mine && state[x-1,y+1].revealed!=true){
                        state[x-1,y+1].revealed=true;
                        if (state[x-1,y+1].type==Cell.Type.Empty){
                            Flood(x-1,y+1);
                        }
                    }
                    //top middle
                    if (y!=(height-1) && state[x,y+1].type!=Cell.Type.Mine && state[x,y+1].revealed!=true){
                        state[x,y+1].revealed=true;
                        if (state[x,y+1].type==Cell.Type.Empty){
                            Flood(x,y+1);
                        }
                    }
                    //top right
                    if (x!=(width-1) && y!=(height-1) && state[x+1,y+1].type!=Cell.Type.Mine && state[x+1,y+1].revealed!=true){
                        state[x+1,y+1].revealed=true;
                        if (state[x+1,y+1].type==Cell.Type.Empty){
                            Flood(x+1,y+1);
                        }
                    }
                    //middle left
                    if ( x!=0 && state[x-1,y].type!=Cell.Type.Mine && state[x-1,y].revealed!=true){
                        state[x-1,y].revealed=true;
                        if (state[x-1,y].type==Cell.Type.Empty){
                            Flood(x-1,y);
                        }
                    }
                    //middle right
                    if (x!=(width-1) && state[x+1,y].type!=Cell.Type.Mine && state[x+1,y].revealed!=true){
                        state[x+1,y].revealed=true;
                        if (state[x+1,y].type==Cell.Type.Empty){
                            Flood(x+1,y);
                        }
                    }
                    //bottom left
                    if (x!=0 && y!=0 && state[x-1,y-1].type!=Cell.Type.Mine && state[x-1,y-1].revealed!=true){
                        state[x-1,y-1].revealed=true;
                        if (state[x-1,y-1].type==Cell.Type.Empty){
                            Flood(x-1,y-1);
                        }
                    }
                    if (y!=0 && state[x,y-1].type!=Cell.Type.Mine && state[x,y-1].revealed!=true){
                        state[x,y-1].revealed=true;
                        if (state[x,y-1].type==Cell.Type.Empty){
                            Flood(x,y-1);
                        }
                    }
                    if (x!=(width-1) && y!=0 && state[x+1,y-1].type!=Cell.Type.Mine && state[x+1,y-1].revealed!=true){
                        state[x+1,y-1].revealed=true;
                        if (state[x+1,y-1].type==Cell.Type.Empty){
                            Flood(x+1,y-1);
                        }
                    }
        }
    }
    private void Flag()
    {
        Vector3 worldPosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int cellPosition = board.tilemap.WorldToCell(worldPosition);
        Cell cell= GetCell(cellPosition.x, cellPosition.y);

        if (cell.type ==Cell.Type.Invalid || cell.revealed){
            return;        
        }

        if (cell.flagged == true){
            cell.flagged = false;
        } else{
            cell.flagged = true;
        }
        state[cellPosition.x, cellPosition.y]=cell;
        board.Draw(state);
        
    }
    private Cell GetCell(int x, int y)
    {
        if(IsValid(x,y)){
            return state[x,y];
        } else{
            return new Cell();
        }
    }

    private bool IsValid(int x, int y)
    {
        return x>=0 && x<width && y>=0 && y<height;
    }

    private void Win(){
        int win=0;
        for (int x=0; x<width; x++){
            for(int y=0; y<height; y++){
                if (state[x,y].revealed || state[x,y].type==Cell.Type.Mine){
                    win++;
                }
            }
        }
        if (win==height*width){
            Debug.Log("You Won!");
            gameOver=true;
            textWin.SetActive(true);
            textInstruct.SetActive(true);
            for (int x=0; x<width; x++){
                for(int y=0; y<height; y++){
                    if (state[x,y].type==Cell.Type.Mine){
                        state[x,y].flagged=true;
                        board.Draw(state);
                    }
                }
            }
        }else{
            return;
        }
    }
}
