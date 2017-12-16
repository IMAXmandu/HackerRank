    public Difference(int[] a)
    {
        this.elements = a;
    }

    public void computeDifference()
    {
        maximumDifference = elements.Max() - elements.Min();
    }