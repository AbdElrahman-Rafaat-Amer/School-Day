package com.example.schoolday.student.feespackage;

public class Fees {
    int id;
    String name;
    String status;
    int amount;
    String payMethod;
    int discount;
    String date;
    int paid;
    int fine;
    public Fees() {
    }

    public Fees(int id, String name, String status, int amount, String payMethod, int discount, String date, int paid, int fine) {
        this.id = id;
        this.name = name;
        this.status = status;
        this.amount = amount;
        this.payMethod = payMethod;
        this.discount = discount;
        this.date = date;
        this.paid = paid;
        this.fine = fine;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }

    public String getPayMethod() {
        return payMethod;
    }

    public void setPayMethod(String payMethod) {
        this.payMethod = payMethod;
    }

    public int getDiscount() {
        return discount;
    }

    public void setDiscount(int discount) {
        this.discount = discount;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public int getPaid() {
        return paid;
    }

    public void setPaid(int paid) {
        this.paid = paid;
    }

    public int getFine() {
        return fine;
    }

    public void setFine(int fine) {
        this.fine = fine;
    }
}
