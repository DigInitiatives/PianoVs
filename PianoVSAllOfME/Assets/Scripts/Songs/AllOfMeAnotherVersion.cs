using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllOfMeAnotherVersion : Songholder
{
    public AllOfMeAnotherVersion()
    {
        songNotes = new List<NoteClass>();

        SetBPM(140);
        SetTimeSignature(4);
        //SetMaxBeat((timeSignature * 16));
        int barTime = timeSignature * 16;
        int rightBarCount = 0;

        // Bar 1
       
        songNotes.Add(new NoteClass(f3, 0, 24, 1));
        songNotes.Add(new NoteClass(c4, 0, 24, 1));

        songNotes.Add(new NoteClass(f3, 24, 48, 1));
        songNotes.Add(new NoteClass(c4, 24, 48, 1));

        songNotes.Add(new NoteClass(f3, 48, 64, 1));
        songNotes.Add(new NoteClass(c4, 48, 64, 1));

        rightBarCount++;

        // Bar 2
   
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(cSharp4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));


        rightBarCount++;

        //Bar 3
    
        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 4
        
        songNotes.Add(new NoteClass(dSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 0 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 24 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(aSharp3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 5
       
        songNotes.Add(new NoteClass(f3, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));


        rightBarCount++;

        //Bar 6
      
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));


        rightBarCount++;

        //Bar 7
       
        songNotes.Add(new NoteClass(gSharp3, 0 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 24 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 24 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 8
    
        songNotes.Add(new NoteClass(c4, 0 + (barTime * rightBarCount), 8 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 8 + (barTime * rightBarCount), 16 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 9 
       
        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 56 + (barTime * rightBarCount), 64 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 10 
    
        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 11 
        
        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 12 
        
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 13 
     
        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 14 
     
        songNotes.Add(new NoteClass(c3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 15 
  
        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 16 
    
        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 17 
       
        songNotes.Add(new NoteClass(f3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 18 
       
        songNotes.Add(new NoteClass(cSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 19 

        songNotes.Add(new NoteClass(cSharp4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 20 
      
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 21 
  
        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 22 
    
        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 23 
        
        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 24 
       
        songNotes.Add(new NoteClass(g3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(e3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(a3, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));
        
        rightBarCount++;

        // Next Sheet

        //Bar 25
        
        songNotes.Add(new NoteClass(g3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 26
      
        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 27
     
        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 28
    
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(e4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 29
        
        songNotes.Add(new NoteClass(e4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));
        
        rightBarCount++;

        //Bar 30
        Debug.Log("Bar 30");
        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 31
        Debug.Log("Bar 31");
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(a3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 32
      
        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 48 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;


        //Bar 33
  
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;


        //Bar 34
      
        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 35
   
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 36

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 37
     
        songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 38
      
        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 39
        
        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(a3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;
        
        //Bar 40

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;
                
        //Bar 41

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;
        
        //Bar 42

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;
        
        //Bar 43

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(gSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(aSharp3, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;
        
        //Bar 44

        songNotes.Add(new NoteClass(gSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(a4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;
        
        
        //Bar 45

        songNotes.Add(new NoteClass(a4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 46

        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;
        
        //Bar 47

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;
        
        //Bar 48

        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp3, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;
        

        //Bar 49

        songNotes.Add(new NoteClass(a4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(g4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(f4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 50

        songNotes.Add(new NoteClass(f4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(dSharp4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 56 + (barTime * rightBarCount), 1));

        rightBarCount++;
                
        //Bar 51

        songNotes.Add(new NoteClass(c4, 16 + (barTime * rightBarCount), 32 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(c4, 32 + (barTime * rightBarCount), 40 + (barTime * rightBarCount), 1));

        songNotes.Add(new NoteClass(cSharp4, 40 + (barTime * rightBarCount), 48 + (barTime * rightBarCount), 1));

        rightBarCount++;

        //Bar 52


       


    }
}
