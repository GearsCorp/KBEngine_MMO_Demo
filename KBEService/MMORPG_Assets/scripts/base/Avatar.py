# -*- coding: utf-8 -*-
import KBEngine;
from KBEDebug import* ;

class Avatar(KBEngine.Proxy):
    def __init__(self):
        KBEngine.Proxy.__init__(self);

    def onTimer(self,id,userArg):
        DEBUG_MSG(id,userArg);

    def onClientEnabled(self):
        INFO_MSG("account[%i] entities enable. entityCall:%s" % (self.id, self.client));

    def onLogOnAttempt(self,ip,port,passeord):
        INFO_MSG(ip,port,passowrd);

    def onClientDeth(self):
        DEBUG_MSG("Account[%i].onClientDeath:" % self.id);
        self.destroy();