/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ktu.ds.lab2.demo.ložys;

import edu.ktu.ds.lab2.utils.Ks;
import edu.ktu.ds.lab2.utils.Parsable;
import java.util.Comparator;
import java.util.InputMismatchException;

/**
 *
 * @author paulius
 */
public class Book implements Parsable<Book>{

        private String name;
        private String author;
        private int releaseYear;
        private int pageCount;
        
        
    public Book(String data){
        parse(data);
    }

    public Book(String name, String author, int releaseYear, int pageCount) {
        this.name = name;
        this.author = author;
        this.releaseYear = releaseYear;
        this.pageCount = pageCount;
    }
        
        

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAuthor() {
        return author;
    }
    
    public void setAuthor(String author) {
        this.author = author;
    }

    public int getReleaseYear() {
        return releaseYear;
    }

    public void setReleaseYear(int releaseYear) {
        this.releaseYear = releaseYear;
    }

    public int getPageCount() {
        return pageCount;
    }

    public void setPageCount(int pageCount) {
        this.pageCount = pageCount;
    }
    
    public String print(){
        return String.format("Name: %-20s Author: %-20s Release year: %6d Page count: %6d", name,author,releaseYear,pageCount);
    }

    
    public final static Comparator byReleaseYear = new Comparator(){
            @Override
            public int compare(Object o1, Object o2) {
                if(((Book)o1).releaseYear < ((Book)o2).releaseYear)
                    return -1;
                else if(((Book)o1).releaseYear > ((Book)o2).releaseYear)
                    return +1;
                else
                    return 0;
            }
    };
    
    public final static Comparator byPageCount = new Comparator() {
            @Override
            public int compare(Object o1, Object o2) {
              
            if(((Book)o1).pageCount < ((Book)o2).pageCount)
                return -1;
            else if(((Book)o1).pageCount > ((Book)o2).pageCount)
                return +1;
            else
                return 0;
            }
    };
    
    public final static Comparator byAuthor = new Comparator() {
            @Override
            public int compare(Object o1, Object o2) {
            
                return ((Book)o1).author.compareTo(((Book)o2).author);
            }
    
    
    };
    
    public final static Comparator byName = new Comparator(){
            @Override
            public int compare(Object o1, Object o2) {
            
            return ((Book)o1).name.compareTo(((Book)o2).name);
            }
            
            };
   
    
    @Override
    public void parse(String data) {
     try {
         
            String[] line = data.split(";", -2);
         
            name = line[0];
            author = line[1];
            releaseYear = Integer.parseInt(line[2]);
            pageCount = Integer.parseInt(line[3]);         
            
        } catch (InputMismatchException e) {
            Ks.ern("Blogas duomenų formatas -> " + data);
        } catch (IndexOutOfBoundsException e){
            Ks.ern("Trūksta duomenų -> " + data);
        } }

    @Override
    public int compareTo(Book other) {
        
        if(name.compareTo(other.name) != 0){
            return name.compareTo(other.name);
        }
        
        return author.compareTo(other.author);
    }
    
    @Override
    public String toString() {
        return String.format("%s;%s;%d;%d",
                name, author, releaseYear, pageCount);
    }

    
}
