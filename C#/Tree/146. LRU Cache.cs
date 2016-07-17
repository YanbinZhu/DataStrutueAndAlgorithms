/*146. LRU Cache
    Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and set.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
set(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.*/

public class LRUCache {

    
    private Dictionary<int, CacheNode> cacheItems;
    private int maxCapacity;
    private CacheNode header;
    
    public LRUCache(int capacity) {
        cacheItems=new Dictionary<int, CacheNode>();
        maxCapacity=capacity;
        header=new CacheNode();
    }

    public int Get(int key) {
        
        if(cacheItems.ContainsKey(key))
        {
            var node=cacheItems[key];
            deleteNode(key);
            Set(key, node.value);
            return node.value;
        }
        
        return -1;
    }
    
    public void putAtTheBegin(CacheNode node)
    {
        if(header.next==null)
        {
            node.pre=header;
            header.next=node;
            return;
        }
        
        if(node.pre==header)
            return;
        
        node.pre=null;
        node.next=null;
        node.next=header.next;
        header.next.pre=node;
        node.pre=header;
        header.next=node;
    }
    
    
    public void deleteNode(int key)
    {
        if(cacheItems.ContainsKey(key))
        {
            //delete node
            var deleteNode=cacheItems[key];
            
            deleteNode.pre.next=deleteNode.next;
            if(deleteNode.next!=null)
                deleteNode.next.pre=deleteNode.pre;
            deleteNode.next=null;
            deleteNode.pre=null;
            
            cacheItems.Remove(key);
        }
    }

    public void Set(int key, int value) {
    
        deleteNode(key);
        
        //over the max capacity
        
        if(cacheItems.Count == maxCapacity)
        {
            //remove the last node
            var newHeader=header;
            while(newHeader.next!=null)
            {
                newHeader=newHeader.next;
            }
            
            deleteNode(newHeader.key);
        }
        
        //create a node at the begining//put it at the begin
        
        CacheNode node=new CacheNode();
        node.key=key;
        node.value=value;
        putAtTheBegin(node);
        cacheItems.Add(key,node);
    }
}

public class CacheNode
{
    public int key;
    public int value;
    public CacheNode next;
    public CacheNode pre;
}

