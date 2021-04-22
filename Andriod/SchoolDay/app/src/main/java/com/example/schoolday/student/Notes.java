package com.example.schoolday.student;

public class Notes {
/*
    private String title, text, dateAndTime;
    private int id;

    public String getTitle() {
        return title;
    }

    public String getText() {
        return text;
    }

    public String getDateAndTime() {
        return dateAndTime;
    }

    public int getId() {
        return id;
    }
    */

    private String name, team, bio, imageurl;

    public String getBio() {
        return bio;
    }

    public void setBio(String bio) {
        this.bio = bio;
    }

    public String getImageurl() {
        return imageurl;
    }

    public void setImageurl(String imageurl) {
        this.imageurl = imageurl;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getTeam() {
        return team;
    }

    public void setTeam(String team) {
        this.team = team;
    }


}
