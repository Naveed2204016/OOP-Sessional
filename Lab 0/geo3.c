#include<stdio.h> 
struct circle 
{ 
    float dia; 
}; 
struct rectangle 
{ 
    float height; 
    float width; 
}; 

struct cube
{
    float height;
    float width;
    float depth;
};
struct shape 
{ 
    int id; 
    struct circle c; 
    struct rectangle r;
    struct cube cu; 
}; 
 
int main() 
{ 
    struct shape e1[100]; 
    int cnt=0,rec=0,cir=0,cub=0;
    while(1) 
    { 
        int a; 
        printf("1. Add a circle\n"); 
        printf("2. Add a rectangle\n");
        printf("3. Add a cube\n");
        printf("4. List items\n"); 
        printf("5. Get statistic\n"); 
        printf("6. Exit\n"); 
        scanf("%d",&a); 
        if(a==1) 
        { 
            printf("What is the diameter:\n"); 
            scanf("%f",&e1[cnt].c.dia); 
            e1[cnt].id=0; 
            cnt++; 
            cir++; 
        } 
        else if(a==2) 
        { 
            printf("What is the height:\n"); 
            scanf("%f",&e1[cnt].r.height); 
            printf("What is the width:\n"); 
            scanf("%f",&e1[cnt].r.width); 
            e1[cnt].id=1; 
            cnt++; 
            rec++; 
        }
        else if(a==3)
        {
            printf("What is the height:\n");
            scanf("%f",&e1[cnt].cu.height);
            printf("What is the width:\n");
            scanf("%f",&e1[cnt].cu.width);
            printf("What is the depth:\n");
            scanf("%f",&e1[cnt].cu.depth);
            e1[cnt].id=2;
            cnt++;
            cub++;
        }
        else if(a==4) 
        { 
            printf("Id   type   dimension\n"); 
            printf("=======================\n"); 
            printf("\n"); 
            for(int i=0;i<cnt;i++) 
            { 
            if(e1[i].id==0) 
            { 
            printf("%d  circle  %.2f\n",i+1,e1[i].c.dia); 
            } 
            else if(e1[i].id==1)
            { 
            printf("%d  rectangle %.2f X %.2f\n",i+1,e1[i].r.height,e1[i].r.width); 
            } 
            else
            {
            printf("%d  cube %.2f X %.2f X %.2f\n",i+1,e1[i].cu.height,e1[i].cu.width,e1[i].cu.depth);  
            }
            } 
            printf("\n"); 
        } 
        else if(a==5) 
        { 
 
            float tot=0,circa=0,recta=0,cuba=0; 
            for(int i=0;i<cnt;i++) 
            { 
            if(e1[i].id==0) 
            { 
            tot+=3.1416*(e1[i].c.dia/2.0)*(e1[i].c.dia/2.0); 
            circa+=3.1416*(e1[i].c.dia/2.0)*(e1[i].c.dia/2.0); 
            } 
            else if(e1[i].id==1)
            { 
            tot+=e1[i].r.height*e1[i].r.width; 
            recta+=e1[i].r.height*e1[i].r.width; 
            }
            else
            {
            tot+=2*(e1[i].cu.height*e1[i].cu.width+e1[i].cu.width*e1[i].cu.depth+e1[i].cu.depth*e1[i].cu.height);
            cuba+=2*(e1[i].cu.height*e1[i].cu.width+e1[i].cu.width*e1[i].cu.depth+e1[i].cu.depth*e1[i].cu.height);
            } 
            } 
            printf("Total shapes: %d\n",cnt); 
            printf("Total number of Rectanges: %d\n",rec); 
            printf("Total number of Circles: %d\n",cir);
            printf("Total number of Cube: %d\n",cub);
            printf("Total area %.2f\n",tot); 
            printf("The total area occupied by rectangles: %.2f (%.2f%%)\n",recta,(recta/tot)*100.0); 
            printf("The total area occupied by circles: %.2f (%.2f%%)\n",circa,(circa/tot)*100.0); 
            printf("The total area occupied by cubes: %.2f (%.2f%%)\n",cuba,(cuba/tot)*100.0); 
    } 
    else 
    break; 
    } 
}