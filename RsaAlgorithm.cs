using System;

public class RsaAlgorithm {
  private int p, q, n, phi, d;

  public RsaAlgorithm(int p, int q){
    this.p = p;
    this.q = q;

    this.n = p*q;
    this.phi = (p-1)*(q-1);
  }

  public int getP () {
    return this.p;
  }

  public int getQ () {
    return this.q;
  }

  public int getN () {
    return this.n;
  }

  public int getPhi () {
    return this.phi;
  }

  public int getD () {
    return this.d;
  }
}