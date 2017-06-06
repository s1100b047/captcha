var myTimer=0;
function timedCount()
{
    myTimer = setInterval(myCounter, 1000);
}
function gettime()
{
    return myTimer;
}