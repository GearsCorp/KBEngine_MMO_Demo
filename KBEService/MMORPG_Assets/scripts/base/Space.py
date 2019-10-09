# -*- coding: utf-8 -*-
import KBEngine;
from KBEDebug import* ;

class Space(KBEngine.Entity):
    def __init__(self):
        KBEngine.Entity.__init__(self);

    def onTimer(self,id,userArg):
        DEBUG_MSG(id,userArg);