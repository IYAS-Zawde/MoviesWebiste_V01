//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesWebiste_V01
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.orders = new HashSet<order>();
            this.ratings = new HashSet<rating>();
            this.actors = new HashSet<actor>();
            this.channels = new HashSet<channel>();
            this.creterias = new HashSet<creteria>();
            this.directors = new HashSet<director>();
            this.movies = new HashSet<movie>();
            this.technologies = new HashSet<technology>();
            this.hoppies = new HashSet<hoppy>();
        }
    
        public int ID { get; set; }
        public string name { get; set; }
        public Nullable<int> age { get; set; }
        public string email { get; set; }
        public Nullable<int> education_level_id { get; set; }
        public Nullable<int> gender { get; set; }
        public Nullable<int> home_owner_id { get; set; }
        public Nullable<int> internet_connection_id { get; set; }
        public Nullable<int> marital_status_id { get; set; }
        public Nullable<double> num_bathrooms { get; set; }
        public Nullable<int> movie_selector_id { get; set; }
        public Nullable<int> num_bedrooms { get; set; }
        public Nullable<int> num_cars { get; set; }
        public Nullable<int> num_childerns { get; set; }
        public Nullable<int> num_tvs { get; set; }
        public Nullable<int> pptv_frequent_id { get; set; }
        public Nullable<int> baying_frequent_id { get; set; }
        public Nullable<int> reating_frequent_id { get; set; }
        public Nullable<int> viewing_frequent_id { get; set; }
        public Nullable<int> theater_frequent_id { get; set; }
        public Nullable<int> tv_movie_frequent_id { get; set; }
        public Nullable<int> tv_signal_id { get; set; }
        public Nullable<int> format_id { get; set; }
    
        public virtual education_level education_level { get; set; }
        public virtual format format { get; set; }
        public virtual frequently frequently { get; set; }
        public virtual frequently frequently1 { get; set; }
        public virtual frequently frequently2 { get; set; }
        public virtual frequently frequently3 { get; set; }
        public virtual frequently frequently4 { get; set; }
        public virtual frequently frequently5 { get; set; }
        public virtual home_owner home_owner { get; set; }
        public virtual internet_connection internet_connection { get; set; }
        public virtual marital_status marital_status { get; set; }
        public virtual movie_selector movie_selector { get; set; }
        public virtual tv_signal tv_signal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rating> ratings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<actor> actors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<channel> channels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creteria> creterias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<director> directors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movie> movies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<technology> technologies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoppy> hoppies { get; set; }
    }
}
