#include<bits/stdc++.h>
using namespace std;string T,S;
int find(string T,string S){int m = T.size();int n = S.size();int j = 0;for(int i = 0 ; i < m-n; i++){while(j < n && T[i+j]==S[j]){j++;}if(j == n){return i;}}return -1;}int main(){T="ABABDAABACDABABCABAB";S="ABABCABAB";cout<<find(T,S);}
