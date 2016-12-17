# Roll-A-Ball
Using Unity3d
## Camera follow the ball
摄像机和主角的偏移距离固定，position只差保持一致，就可以实现了
## food 
要使物体以一个轴为轴心旋转，以Y轴为例，就是在Y轴方向Rotate一个向量
## Move
设定主角为刚体，这样他就获得了现实中的重力，移动因为角色为刚体，我们可以给他提供一个Force让他进行移动，Unity本身按WASD就可以移动，Input.GetAxis("Horizontal")
获取水平的偏移量，默认为1，GetAxis("Vertical")
