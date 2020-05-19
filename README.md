# ZedGraphLive
 SerialPlotter


With the lack of actual tutorials of how to use the ZedGraph to plot LIVE serial data. 
This is a shortcut to your salvation.

Note: I am not an experienced programmer, use this as a template.
Due to it being unrefined code, use at discretion, no credit to me needed, but a shoutout is appreciated.

Theory of Operation:

Data is read from microcontrollers that use the "printf" function, the format is standard for most ARM architectures
This was NOT tested to work with fprintf or sprintf, much debugging is needed if using that stream type

Expected data is ASCII (HEX might work, but was not tested for this data type)
Converts a string data type to double in C# side, then plots the double value onto the zedgraph
Time scale is not exact, requires tuning.

Data is streamed live.
Just build and use. Tweak as necessary
